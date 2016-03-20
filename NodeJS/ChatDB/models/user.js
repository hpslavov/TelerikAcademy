var mongoose = require('mongoose');
var CustomUser;
module.exports = {
    init:function(){
        var customUserSchema = new mongoose.Schema({
            username: String,
            password: String,
            messages: {
                recievedMessages:[],
                sentMessages:[]
            }
        });

        CustomUser = mongoose.model('CustomUser', customUserSchema);
    },
    registerUser:function(userName,password){
        var userToRegister = new CustomUser({
            username:userName,
            password:password
        });

        userToRegister.save(function(err,result){
            if(err){
                console.log(err);
            }
            console.log(result);
        })
    },
    userModel: function(){
        return CustomUser;
    }
};