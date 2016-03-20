var auth = require('./auth'),
    controllers = require('../controllers');

module.exports = function(app) {
    app.get('/register', controllers.users.getRegister);
    app.post('/register', controllers.users.postRegister);

    app.get('/login', controllers.users.getLogin);
    app.post('/login', auth.login);

    app.get('/logout', auth.logout);
    app.get('/profile',controllers.users.getProfile);

    app.get('/profile/edit',controllers.users.getEdit);
    app.post('/profile/edit',controllers.users.postEdit);

    app.get('/playlist/create',controllers.playlist.getCreate);
    app.post('/playlist/create',controllers.playlist.postCreate);

    app.get('/playlist/:id',controllers.playlist.getDetails);
    app.post('/playlist/:id',controllers.playlist.postEdit);

    app.get('/playlist/:id/rate',controllers.playlist.rate);
    app.post('/playlist/:id/rate',controllers.playlist.postRate);

    app.get('/playlist/:id/comment',controllers.playlist.getComment);
    app.post('/playlist/:id/comment',controllers.playlist.postComment);

    app.get('/delete',controllers.playlist.deletePlaylist);

    app.get('/search',controllers.playlist.getSearch);
    app.get('/filteredCategory',controllers.playlist.getCategoriesResults);
    app.get('/filteredTitle',controllers.playlist.getTitleResults)
    app.get('/', controllers.playlist.getTop);

    app.get('*', controllers.playlist.getTop);
};