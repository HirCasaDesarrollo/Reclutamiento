// import { library } from '@fortawesome/fontawesome-svg-core';
// import { FontAwesomeIcon } from '@fortawesome/vue-fontawesome';
// import { faHouse, f0ae } from '@fortawesome/free-solid-svg-icons';

import { createApp } from 'vue'
import App from './App.vue'

import router from './router'

// library.add(faHouse, f0ae)

//.component('font-awesome-icon', FontAwesomeIcon )

createApp(App).use(router).mount('#app')
