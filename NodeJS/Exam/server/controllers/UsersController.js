var encryption = require('../utilities/encryption');
var users = require('../data/users');

var CONTROLLER_NAME = 'users';

module.exports = {
    getRegister: function(req, res, next) {
        res.render(CONTROLLER_NAME + '/register')
    },
    postRegister: function(req, res, next) {
        var newUserData = req.body;
        if(newUserData.username.length < 6 || newUserData.username.length > 20){
            req.session.error = 'Name should be between 6 and 20 characters!';
            res.redirect('/register');
        }
        if(newUserData.firstName.length < 1){
            req.session.error = 'First name is required!';
            res.redirect('/register');
        }
        if(newUserData.lastName.length < 1){
            req.session.error = 'Last name is required!';
            res.redirect('/register');
        }
        if (newUserData.password != newUserData.confirmPassword) {
            req.session.error = 'Passwords do not match!';
            res.redirect('/register');
        }
        else {
            newUserData.salt = encryption.generateSalt();
            newUserData.hashPass = encryption.generateHashedPassword(newUserData.salt, newUserData.password);
            users.create(newUserData, function(err, user) {
                if (err) {
                    console.log('Failed to register new user: ' + err);
                    return;
                }

                req.logIn(user, function(err) {
                    if (err) {
                        res.status(400);
                        return res.send({reason: err.toString()}); // TODO:
                    }
                    else {
                        res.redirect('/');
                    }
                })
            });
        }
    },
    getLogin: function(req, res, next) {
        res.render(CONTROLLER_NAME + '/login');
    },
    getProfile:function(req,res,next){
        users.getById(req.user,function(err,user){
            if(err){
                console.log(err);
            }
            res.render(CONTROLLER_NAME + '/profile',{user:user});
        });
    },
    getEdit:function(req,res){
        var user = req.user;
        res.render(CONTROLLER_NAME + '/edit',{user:user});
    },
    postEdit:function(req,res){
        var user = req.user;
        var editUser = req.body;
        user['email'] = editUser['email'];
        user['firstName'] = editUser['firstName'];
        user['lastName'] = editUser['lastName'];
        user['password'] = editUser['password'];
        user['avatar'] = editUser['avatar'];
        user.save();
        res.redirect('/profile');
    }
};