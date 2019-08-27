import Vue from 'vue'
import Vuex from 'vuex'
import VuexPersistence from 'vuex-persist'

Vue.use(Vuex);
const vuexLocal = new VuexPersistence({
  storage: window.localStorage
});

export default new Vuex.Store({
  state: {
    isLogged: false,
    Email:"",
    cart:[]

  },
  mutations: {
    login (state, value) {
      state.Email = value.Email;
      state.isLogged = true;
    },
    logout (state){
      state.email = "";
      state.isLogged = false
    },
    addToCart (state, value){
      state.cart.push(value);
    },
    clearCart(state){
      state.cart = []
    }
  },
  actions: {

  },
  plugins: [vuexLocal.plugin]
})
