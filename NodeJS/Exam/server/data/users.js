var User = require('mongoose').model('User');

module.exports = {
    create: function(user, callback) {
        User.create(user, callback);
    },
    getById:function(user,callback){
        User.findOne({username:user.username},callback);
    }
};