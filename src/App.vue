<template>
  <div id="app">
<!--    <b-nav  v-if="isLogged" tabs align="center" class="nav menu">-->
<!--      <b-nav-item  active><router-link  to="/home">Home</router-link></b-nav-item>-->
<!--      <b-nav-item active><router-link to="/About">about</router-link></b-nav-item>-->
<!--      <b-nav-item active><router-link to="/Cart"><i class="fas fa-shopping-cart" style="margin-right: 5px;"></i>-->
<!--        <span v-if="notifications == 0" class="badge badge-light">{{notifications}}</span>-->
<!--        <span v-else-if="notifications > 0" class="badge badge-danger">{{notifications}}</span></router-link></b-nav-item>-->
<!--      <b-nav-item><a class="link" @click="logout" >Logout</a></b-nav-item>-->
<!--    </b-nav>-->

    <b-navbar v-if="isLogged" toggleable="lg" type="dark" class="navbartop fixed-top">
      <b-navbar-toggle target="nav-collapse"></b-navbar-toggle>
      <b-collapse id="nav-collapse" is-nav>
        <b-navbar-nav>
          <b-nav-item ><router-link class="navbaritem" to="/home">Home</router-link></b-nav-item>
          <b-nav-item ><router-link class="navbaritem" to="/Profile">About</router-link></b-nav-item>
          <b-nav-item ><router-link class="navbaritem" to="/Cart"><i class="fas fa-shopping-cart" style="margin-right: 5px;"></i>
            <span v-if="notifications == 0" class="badge badge-light">{{notifications}}</span>
            <span v-else-if="notifications > 0" class="badge badge-danger">{{notifications}}</span></router-link></b-nav-item>
        </b-navbar-nav>

        <!-- Right aligned nav items -->
        <b-navbar-nav class="ml-auto">
          <b-nav-item><a class="link" @click="logout" >Logout</a></b-nav-item>
        </b-navbar-nav>
      </b-collapse>
    </b-navbar>

      <b-navbar v-if="isLogged===false" toggleable="lg" type="dark" class="navbartopBlack fixed-top">
          <b-navbar-toggle target="nav-collapse"></b-navbar-toggle>
          <b-collapse id="nav-collapse" is-nav>
              <!-- Right aligned nav items -->
              <b-navbar-nav>
                  <b-nav-item  ><img src="./assets/Vapiano-Logo-650x315.jpg" style="height: 30px;padding-bottom:8px; "></b-nav-item>
                 <!-- <b-nav-item style="margin-left: 320%" ><router-link class="navbaritemBlack" to="/login">Bejelentkezés</router-link></b-nav-item>
                  <b-nav-item ><router-link class="navbaritemBlack" to="/signUp">Regisztráció</router-link></b-nav-item> -->
              </b-navbar-nav>
          </b-collapse>
      </b-navbar>



    <transition name="fade">
      <router-view/>
    </transition>
  </div>
</template>
<script>
  import store from "./store"
  export default {
    name: "Login",
    data() {
      return {


      };
    },
    methods: {
      logout: function() {
        store.commit('logout');
        this.$router.push("login")
      }
    },
    computed: {
      isLogged(){
        return store.state.isLogged
      },
      cartIsEmpty(){
        return store.state.cart.length > 0
      },
      notifications() {
        return store.state.cart.length;
      }
    }


  }
</script>
<style>
  #app {
    font-family: 'Avenir', Helvetica, Arial, sans-serif;
    -webkit-font-smoothing: antialiased;
    -moz-osx-font-smoothing: grayscale;
    text-align: center;
    color: #2c3e50;

  }
  #nav {
  }

  #nav a {
    font-weight: bold;
  }

  #nav a.router-link-exact-active {

  }

  .fade-enter,
  .fade-leave-to {
    opacity: 0;
  }

  .fade-enter-active,
  .fade-leave-active {
    transition: 0.5s;
  }

  .menu {
    background-color: rgba(0, 0, 0, 0.7);
  }

  .navbartop{
    background-color: rgba(0, 0, 0, 0.7);
  }
  navbartopBlack{
      background: white;

  }



  .navbaritem{
    color: white;
  }
  .navbaritemBlack{
      color: black;
  }
</style>
