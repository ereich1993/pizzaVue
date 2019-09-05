<template>
    <div id="app">
        <About></About>
        <b-container class="container">
            <b-row id="outerRow">
                <b-col>
                    <div style="text-align: left">
                    </div>
                    <div style="margin-top: 20px" v-for="(value,index) in items" :key="index">
                        <ProductCard :value="value"></ProductCard>
                    </div>
                </b-col>
                <b-col col lg="4" class="cardContainer">
                    <div  class="card">
                        <b-row id="upper">
                            <b-col class="cardLeft" lg="8">
                                <p style="font-family: Helvetica; font-size: 20px;margin-bottom: 20px">Összeités</p>
                                <p>Van promocios kódod?</p>
                                <p>Részösszeg</p>
                                <p>várható szállítás és kezelés</p>
                                <p style="font-size: 20px">Összesen: {{totalAmount}}</p>
                            </b-col>
                            <b-col  class="cardRight" lg="*">

                            </b-col>
                        </b-row>
                        <b-button v-on:click="clear" >Fizetés</b-button>
                        <b-button class="whiteCard">PayPal</b-button>


                    </div>
                </b-col>
            </b-row>
        </b-container>
    </div>
</template>

<script>
    import store from "../store"
    import About from "./About"
    import ProductCard from "../components/ProductCard";
    import {restPost} from "../RestClient/consumer"
import { async } from 'q';
    export default {
        mounted () {



        },
        name: "Cart",
        components: {About, ProductCard},
        data:function() {
            return{

                pr: {
                    image: require("../assets/sushi.jpg")
                },
            }
        },
        computed : {
            items  : function () {
                return store.state.cart
            },
            totalAmount : function () {
                var counter = 0;
                let carrr = store.state.cart;
                //console.log(carrr)
                for (let item in carrr){
                    counter += carrr[item].price
                }
                return counter;
            }
        },
        methods: {
            clear: async function () {
                var myCart = JSON.parse(JSON.stringify(this.items))
                if (myCart.length>0){
                    const resposne = await restPost("Product",myCart)
                }
                //store.commit('clearCart');
            }
        }
    }
</script>

<style scoped>
    .container {
        height: 50rem;
    }
    #outerRow {
        height: 35%;
    }

    .card{
        margin-top: 20px;
        width: 25%;
        background-color: black;
        position: fixed;
    }
    .cardContainer{

    }
    button{
        width: 90%;
        margin-left: 5%;
        margin-right: 5%;
       background-color:  rgb(250, 84, 0);
        color: white;
        border-style: groove;
        border-radius:0 ;
    }
    p{
        font-family: Helvetica;
        font-size: 15px;
        color: white;
        margin-bottom: 5%;

    }
    #app {
        background-color: rgb(239,241,243);
        }
    .cardLeft{
        height: 80%;
        text-align: left;
        margin-left: 5%;
        margin-top: 5%;
    }
    .cardRight{
        height: 80%;
        text-align: right;
        margin-left: 5%;
        margin-top: 5%;
    }
    .whiteCard{
        margin-top: 10px;
        background-color: white;
        color: aqua;
        margin-bottom: 10px;
    }
    .container{
        margin-top: 10px;
    }



</style>