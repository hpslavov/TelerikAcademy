var mongoose = require('mongoose');

var requiredMessage = '{PATH} is required';

module.exports.init = function() {
    var playlistSchema = mongoose.Schema({
        title: {
            type: String,
            required: requiredMessage
        },
        description: {
            type: String,
            required: requiredMessage
        },
        category: {
            type: String,
            required: requiredMessage
        },
        videos:{
            type:Array
        },
        date: {
            type: Date,
            required: requiredMessage
        },
        creator: {
            type: String,
            required: requiredMessage
        },
        comments: [{
            username: String,
            content: String
        }],
        public:{
            type:Boolean
        },
        rating:{
            type:Number
        }
    });

    var Playlist = mongoose.model('Playlist', playlistSchema);
};



