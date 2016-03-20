var dbManager = require('./config/chat-db');
dbManager.init();
dbManager.registerUser('Icaka','123');
dbManager.registerUser('Gosho','123');
dbManager.registerUser('Sideris','123');
dbManager.registerUser('Slavov','123');
var msg = {
    from:'Gosho',
    to:'Icaka',
    text:'Are beeeee!!'
};
var secondMsg = {
    from:'Sideris',
    to:'Slavov',
    text:'OFFFFF beeeee!!'
};

var userQueryObj = {
    with:'Icaka',
    and:'Gosho'
}

dbManager.sendMessage(msg);
dbManager.sendMessage(secondMsg);
dbManager.getMessages(userQueryObj);