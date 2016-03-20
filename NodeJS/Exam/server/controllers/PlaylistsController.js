var playlists = require('../data/playlists');
var constants = require('../common/constants');

var CONTROLLER_NAME = 'playlists';

module.exports = {
    getTop: function (req, res) {
        playlists.getTop(function (err, data) {
            if (err) {
                console.log(err);
            }
            res.render('index', {playlists: data});
        });
    },
    getCreate: function (req, res) {
        res.render(CONTROLLER_NAME + '/create', {categories: constants.categories});
    },
    postCreate: function (req, res) {
        var playlist = req.body;
        var user = req.user;
        console.log(playlist);
        playlists.create(playlist, user, function (err, playlist) {
            if (err) {
                var data = {
                    categories: constants.categories,
                    errorMessage: err
                };
                res.render(CONTROLLER_NAME + '/create', data);
            }
            else {
                user.playlists.push(playlist);
                user.save();
                res.redirect('/playlist/' + playlist._id);
            }
        })
    },
    getEdit: function (req, res) {
        playlists.getById(req, function (err, playlist) {
            res.render(CONTROLLER_NAME + '/edit', {playlist: playlist});
        })
    },
    postEdit: function (req, res) {
        var url = req.body;
        playlists.getById(req, function (err, playlist) {
           playlist.videos.push(url);
            playlist.save();
            res.redirect('/playlist/'+playlist._id);
        });
    },
    getDetails: function (req, res) {
        playlists.getById(req, function (err, playlist) {
            res.render(CONTROLLER_NAME + '/details', {data: playlist});
        })
    },
    rate:function(req,res){
        playlists.getById(req, function (err, playlist) {
            res.render(CONTROLLER_NAME + '/rate',{data:playlist});;
        })

    },
    postRate:function(req,res){
        playlists.getById(req, function (err, playlist) {
            if(playlist.rate > 5){
                req.session.error = 'Rate cannot be more than 5';
            }
            var rate = req.body;
            playlist.rating = +rate.rateValue;
            playlist.save();
            res.redirect('/playlist/' + playlist._id);
        })
    },
    getSearch:function(req,res){
        res.render(CONTROLLER_NAME + '/search',{categories:constants.categories});
    },
    getCategoriesResults:function(req,res){
        playlists.getByFilter(req,function(err,playlists){
            if(err){
                req.session.error = err.message;
            }
            res.render(CONTROLLER_NAME + '/search',{categories:constants.categories,data:playlists});
        })
    },
    getTitleResults:function(req,res){
        playlists.getByTitleFilter(req,function(err,playlists){
            if(err){
                req.session.error = err.message;
            }
            res.render(CONTROLLER_NAME + '/search',{categories:constants.categories,data:playlists});
        })
    },
    getComment:function(req,res){
        playlists.getById(req,function(err,playlist){
            res.render(CONTROLLER_NAME + '/comment',{data:playlist});
        })
    },
    postComment:function(req,res){
        playlists.getById(req, function (err, playlist) {
            if(err){
                req.session.error = err.message;
            }
            var comment = req.body;
            comment.username = req.user.username;
            comment.content = comment.content;
            console.log(comment);
            console.log(playlist);
            playlist.comments.push(comment);
            playlist.save();
            res.redirect('/playlist/' + playlist._id);
        })
    },
    deletePlaylist:function(req,res){
        playlists.deleteById(req,function(err,data){
            res.redirect('/');
        });
    }
}