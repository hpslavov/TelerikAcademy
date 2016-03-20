var mongoose = require('mongoose');
var db = mongoose.connection;
var userModel = require('../models/user');
var messagesModule = require('../models/messages');
module.exports = {
    init: function(){
        mongoose.connect('mongodb://localhost/TestDB');
        userModel.init();
        messagesModule.init();
        db.on('error', function (err) {
            console.log(err);
        });

        db.on('open', function () {
            console.log('Running!');
        });

    },
    registerUser:function(userName,password){
        userModel.registerUser(userName, password);
    },
    sendMessage:function(msgObject){
        messagesModule.sendMessage(msgObject);
    },
    getMessages:function(queryObject){
        messagesModule.getMessages(queryObject);
    }
};
