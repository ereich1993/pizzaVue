<template>
    <div class="login">
        <div class="signUpPicture"></div>
        <div class="signUpContent">
        <input type="text" v-model="email" placeholder="Email"><br>
        <input type="password" v-model="password" placeholder="password"><br>
        <button class="button" @click="signUp">Sign up</button><br>
        <span style="color: white">Go back to <router-link to="Login">login</router-link></span>
        </div>
    </div>

</template>

<script>
    //import router from "../router"

    export default {
        name: "SignUp",
        data() {
            return {
                email:"",
                password:""
            }
        },
        methods: {
            signUp: function() {
                this.$router.push('/')
            }
        }
    }
</script>

<style scoped>
    .signUp {
        margin-top: 40px;
    }

    input {
        border: 1px solid #3a99d9;
        border-radius: 50px;
        background: transparent;
        color: whitesmoke;
        margin: 20px 5px 5px 0px;
        padding: 15px 20px;
        height: 70px;
        font-size: 20px;
        /* display: inline-block; */
    }

    .button {
        height: 60px;
        background-color: #3a99d9;
        transition-duration: 0.4s;
        border: none;
        border-radius: 50px;
        color: whitesmoke;
        padding: 5px 45px;
        text-align: center;
        vertical-align: center;
        text-decoration: none;
        display: inline-block;
        font-size: 20px;
        width: 280px;
        margin-top: 20px;
        font-family: "Open Sans", sans-serif;
    }

    .button:hover {
        background-color: #2d5986;
        color: whitesmoke;
    }

    .button:active {
        background-color: #0b5166;
        color: whitesmoke;
    }

    input:focus {
        outline-width: 0px;
        border: 3px solid #3a99d9;
        border-radius: 50px;
    }

    p {
        margin-top: 40px;
        font-size: 13px
    }
    p a {
        text-decoration: underline;
        cursor: pointer;
    }


    .signUpPicture{
        height: 774px;
        background: center no-repeat  url("../assets/vapiano-signUp.jpg") ;
        background-size: 100%;
        margin-top: 2.9%;
    }
    .signUpContent {
        margin-top: -34%;
        height: 400px;
        width: 400px;
        margin-left: 10%;
        background-color: rgba(0,0,0,0.8);

    }
    
</style>