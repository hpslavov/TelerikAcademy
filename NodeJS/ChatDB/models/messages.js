var mongoose = require('mongoose');
var userModule = require('./user');
var Message;

var config = function(){
    var Schema = mongoose.Schema;
    var sendMessageSchema = new Schema({
        from:String,
        to:String,
        text:String
    });

     Message = mongoose.model('Message',sendMessageSchema);
}

module.exports = {
    init:function(){
        config();
    },
    sendMessage:function(msgObject){
        var userReceiving = userModule.userModel();
        var userSending = userModule.userModel();
        var receiver = msgObject.to;
        var sender = msgObject.from;

        var messageToSave = new Message({
            from: msgObject.from,
            to:msgObject.to,
            text:msgObject.text
        });

        messageToSave.save(function(err,data){
            if(err){
                console.log(err);
            }
            console.log(data);
        });

        userReceiving.findOne({username:receiver},function(err,responseUser){
            if(err){
                console.log(err);
            }
            responseUser.messages.recievedMessages.push(msgObject);
            responseUser.save();
        });

        userSending.findOne({username:sender},function(err,responseUser){
           if(err){
               console.log(err);
           }
            responseUser.messages.sentMessages.push(msgObject);
            responseUser.save();
        });

    },
    getMessages:function(queryObject){
        var from = queryObject.with;
        var to = queryObject.and;
        Message
            .find()
            .where('from').equals(from)
            .where('to').equals(to)
            .exec(function(err,result){
               if(err){
                   console.log(err);
               }
                console.log(result);
            });
    }
}