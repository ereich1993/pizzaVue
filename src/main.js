import Vue from 'vue'
import App from './App.vue'
import router from './router'
import store from './store'
import VueLodash from 'vue-lodash'
import BootstrapVue from 'bootstrap-vue'
import axios from 'axios'
const options = { name: 'lodash' } // customize the way you want to call it
Vue.use(BootstrapVue)
Vue.use(VueLodash, options) // options is optional
var VueScrollTo = require('vue-scrollto');
Vue.use(VueScrollTo)
Vue.use(axios)

Vue.config.productionTip = false
import 'bootstrap/dist/css/bootstrap.css'
import 'bootstrap-vue/dist/bootstrap-vue.css'


new Vue({
  router,
  store,
  render: h => h(App)
}).$mount('#app')
