<template>
    <div id="profile">
    <div class="container">
        <div class="row">
            <div  class="col-sm-3 left">
                <div class="nav-class" id="nav">
                    <br>
                    <br>
                    <ul>
                        <li><router-link v-on:click.native="Activate('attekintes')" to="#">Overview</router-link></li>
                        <li><router-link v-on:click.native="Activate=('Payment methods')" to="#">Payment methods</router-link></li>
                        <li><router-link to="#">Order history</router-link></li>
                        <li><router-link to="#">Update</router-link></li>
                        <li><router-link to="#">Enter promo code</router-link></li>
                        <li><router-link to="#">License</router-link></li>
                        <li><router-link to="#">Support</router-link></li>
                    </ul>
                </div>
            </div>
            <div class="col-sm right">
                <div  v-if="active==='attekintes'">
                    <attekintes></attekintes>
                </div>
                <div  v-if="active==='Payment methods'">
                    <attekintes></attekintes>
                </div>
            </div>
        </div>
    </div>
    </div>
</template>

<script>
    import attekintes from "../components/attekintes"
    export default {
        name: "Profile",
        components: {
            attekintes
        },
        data (){
            return {
               active:"attekintes"
            }
        },

        methods : {
            Activate (value) {
                this.active = value;
            },

        }
    }
</script>

<style scoped>
    #profile {
        background-color: #EFF1F3;
        height: 100vh;
    }
    .comp {

    }
    .container {
        padding-top: 100px;

    }
    .right {
        padding-left: 0px;
    }
    .left {
        background-color: rgb(247,248,249);
        padding-right: 0px;

    }
    .row {
        height: 600px;
    }

    .contain.container {
        height: 70vh;
        background-color: #FFFFFF;
        border: rgb(230,230,230) solid 1px;
    }

    a:link{
        color: #5397C6;
        text-decoration: none;

    }
    a:visited{
        color: #5397C6;
        text-decoration: none;
    }
    a:hover{
        color: #5397C6;
        text-decoration: none;
    }
    a:active{
        color: #5397C6;
        text-decoration: none;
    }
    a{
        color: #5397C6;
        text-decoration: none;
    }
    #nav {
        font-size: 15px;
    }
    #nav a {
        color: #5397C6;
    }
    #nav active.router-link-exact-active {
        color: white;
        background-color: rgba(178, 215, 255, 0.2);
        border-left: 3px solid #ffe900;
    }
    ul {
        list-style-type: none;
        margin: 0;
        padding: 0;
        width: auto;
        text-align: left;
    }
    li a {
        display: block;
        color: #000;
        padding: 8px 16px;
        text-decoration: none;
        border-top: rgb(230,230,230) solid 0.1px;


    }

    li a:hover:not(.active) {
        background-color: rgba(178, 215, 255, 0.4);
        color: #5397C6;
    }


</style>