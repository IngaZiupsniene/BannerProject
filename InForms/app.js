var app = require('express')();

app.get('/',function(request,response){
   response.sendFile(__dirname+'/input/index.html');
});

app.listen('8000');