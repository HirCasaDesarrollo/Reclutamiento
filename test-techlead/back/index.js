
const server = require('./src/app.js');
const axios = require("axios");
const { conn } = require('./src/db.js');

// Syncing all the models at once.
conn.sync({ force: true }).then(() => {
  server.listen(3001, () => {
    console.log('Servidor listo en http://localhost:3001'); // eslint-disable-line no-console
  });
});
