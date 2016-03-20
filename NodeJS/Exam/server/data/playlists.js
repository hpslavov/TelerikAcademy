var Playlist = require('mongoose').model('Playlist'),
    constants = require('../common/constants');

var cache = {
    expires: undefined,
    data: undefined
};

function getDate(){
    var monthNames = [
        "January", "February", "March",
        "April", "May", "June", "July",
        "August", "September", "October",
        "November", "December"
    ];

    var date = new Date();
    var day = date.getDate();
    var monthIndex = date.getMonth();
    var year = date.getFullYear();

    console.log(day, monthNames[monthIndex], year);
    var returnDate = (day + ' ' + monthNames[monthIndex] + ' ' + year);
    return returnDate
}


module.exports = {
    create: function(playlist, user, callback) {
        if (constants.categories.indexOf(playlist.category) < 0) {
            callback('Invalid category, initiative or season!');
            return;
        }

        playlist.creator = user.username;
        playlist.date = new Date();
        playlist.rating = 0;

        var currentPlayList = new Playlist(playlist);
        currentPlayList.save(callback);
    },
    getTop:function(callback){
        Playlist.find({}).limit(8).sort({rating:'desc'}).exec(function(err,playlists){
            if(err){
                console.log(err);
                return;
            }
            callback(err,playlists);
        });
    },
    getById:function(req,callback){
        var playlist = req.params.id;
        var id = playlist;
        Playlist.findOne({}).where('_id').equals(id).exec(function(err,playlist){
            if(err){
                console.log(err);
            }
            callback(err,playlist);
        });
    },
    getByFilter:function(req,callback){
        var filterOptions = {};

        if(req.query.category) {
            filterOptions.category = req.query.category;
        }

        Playlist.find(filterOptions).exec(function(err,data){
            if(err){
                console.log(err);
            }
            callback(err,data);
        });
    },
    getByTitleFilter:function(req,callback){
        var filterOptions = {};
        if(req.query.title) {
            filterOptions.title = req.query.title;
        }

        Playlist.find(filterOptions).exec(function(err,data){
            if(err){
                console.log(err);
            }
            console.log(data);
            callback(err,data);
        });
    },
    deleteById:function(req,callback){
        var id = req.params.id;
        Playlist.findByIdAndRemove(id,function(err,ad){
            if(err){
                console.log(err);
            }
            callback(ad);
        });
    }
};