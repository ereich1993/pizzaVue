import Vue from 'vue'
import Router from 'vue-router'
import Home from './views/Home.vue'
import Login from "./views/Login"
import SignUp from "./views/SignUp"
import Cart from "./views/Cart";
import About from "./views/About"
import Profile from "./views/Profile"

Vue.use(Router);
import store from "./store"
const router = new Router({
  mode: 'history',
  base: process.env.BASE_URL,
  routes: [
    {
      path: '/home',
      name: 'home',
      component: Home,
      meta: {
        requiresAuth: true
      }
    },
    {
      path:'/Profile',
      name: 'Profile',
      component: Profile,
      meta: {
        requiresAuth: true
      }
    },
    {
      path: '/Cart',
      name: 'Cart',
      component: Cart,
      meta: {
        requiresAuth: true
      }
    },
    {
      path: '/About',
      name: 'About',
      component: About,
      meta: {
        requiresAuth: true
      }
    },
    {
      path:"/login",
      name: "login",
      component:Login
    },
    {
      path:"/signUp",
      name: "signUp",
      component:SignUp
    },
    {
      path: '*',
      redirect: '/login'
    },
    {
      path: '/',
      redirect: '/login'
    }
  ]

});

router.beforeEach((to, from, next) => {
  const currentUser = store.state.isLogged;
  const requiresAuth = to.matched.some(record => record.meta.requiresAuth);

  if (requiresAuth && !currentUser) next('login');
  else if (!requiresAuth && currentUser) next('home');
  else next();
});

export default router;