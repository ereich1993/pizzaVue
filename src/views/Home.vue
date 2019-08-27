<template>
  <div class="home">
    <div class="cards">
    </div>
    <div class="darkBacground"></div>
    <b-container class="descrition">
        <b-row>
        <b-col cols="8" style="padding-top: 50px;font-size: 20px;text-align: left;" ><p style="display: block;margin-left: 20px">{{desc}}</p></b-col>
        <b-col style="padding-top: 50px" cols="1">
          <div class="heart" style="height:54px;width: 54px;border: solid grey 0.5px"><i style="margin-top: 10px;font-size: 2em" class="fas fa-heart size"></i></div>
        </b-col>
          <b-col style="padding-top: 50px" cols="3">
            <div style="height:54px;width: 210px;border: solid grey 0.5px"><i class="fa fa-smile" style="margin-top: 10px;font-size: 2em;left:30px;position: absolute "></i><p style="font-size: 2.5em;">8.8</p></div>
          </b-col>

        </b-row>
    </b-container>
      <b-container>
    <b-row style="margin-bottom: 40px" v-for="row in ProductChunk" :key="row.id">
      <b-col  v-for="category in row" :key="category.id"  ><a href="#" v-scroll-to="'#'+category.Name"><ProductCategory Racket="item"    :category="category" /></a> </b-col>
    </b-row>
      </b-container>


    <div id="Starter" class="container">
      <div class="row" style="margin-bottom: 110px; ">
        <div class="col-sm-2"></div>
        <div class="col-sm-4">
          <h1  style="margin-left: -150px">ANTIPASTI</h1>
          <div  class="row" v-for="item in menu.starters">
            <div v-on:click="addProduct(item)" class="col">
            <small-product-card  :content="item"></small-product-card>
            </div>
          </div>
        </div>
        <div class="col-sm-6">
          <div class="row">
            <div class="col-sm-5"></div>
            <div style="text-align: left" class="col">
              <div style="margin-bottom: 17px"><b style="font-size: 20px">Étterem információk</b></div>
             <div><b>Cím</b></div>
             <div ><p style="margin-bottom: 0px">Vörösmarty tér 3.</p></div>
             <div ><p style="margin-bottom: 0px">1051 Budapest</p></div>
             <a>Mutasd a térképen</a>
              <div style="margin-top: 40px"><b style="font-size: 20px;">Nyitvatartási idők</b></div>
              <div><p style="margin-right: 0px;font-size: 16px;color: grey;margin-bottom: 0px">Hétfő - Péntek    11.00-23.00</p></div>
              <div><p style="margin-right: 0px;font-size: 16px;color: grey; margin-bottom: 0px">Szombat          11.00-24.00</p></div>
              <div><p style="margin-right: 0px;font-size: 16px;color: grey;margin-bottom: 0px">Vasárnap          11.00-23.00</p></div>
            </div>
          </div>
        </div>
      </div>
    </div>
    <div id="Pizza" class="container">
      <div class="row" style="margin-bottom: 110px; ">
        <div class="col-sm-2"></div>
        <div class="col-sm-4">
          <h1 style="margin-left: -150px">Pasta & Pizza</h1>
          <div class="row" v-for="item in menu.mainDish">
            <div v-on:click="addProduct(item)" class="col">
              <small-product-card  :content="item"></small-product-card>
            </div>
          </div>
        </div>
        <div class="col-sm-6">
        </div>
      </div>
    </div>
    <div id="Dessert" class="container">
      <div class="row" style="margin-bottom: 10px; ">
        <div class="col-sm-2"></div>
        <div class="col-sm-4">
          <h1 style="margin-left: -150px">Dolci & cream</h1>
          <div class="row" v-for="item in menu.desserts">
            <div v-on:click="addProduct(item)" class="col">
              <small-product-card  :content="item"></small-product-card>
            </div>
          </div>
        </div>
        <div class="col-sm-6">
        </div>
      </div>
    </div>


  <div class="footer">
  </div>
    <Footer/>
  </div>

</template>
<script>
// @ is an alias to /src
import ProductCategory from "../components/ProductCategory";
import Footer from "../components/Footer";
import smallProductCard from "../components/smallProductCard";
import store from "../store"
export default {

  name: 'home',
  components: {
    Footer,
    ProductCategory,
    smallProductCard
  },
  data (){
    return {
      desc : "Mert gyors, mégis egészséges. Mert olasz, mégis gyors. Mert finom, igényes, ízléses, mégsem drága. És mert nemzetközi, mégis a miénk.",
      productCategories : [
        {
          Name : "Starter",
          Image: require("../assets/vapiano-mozzarella.jpg")
        },
        {
          Name: "Soup",
            Image: require("../assets/vapiano-soup.jpg")
        },
        {
          Name: "Main dish",
            Image: require("../assets/vapiano-pasta1.jpg")
        },
        {
          Name:"Pizza",
            Image: require("../assets/vapiano-pizza2.jpg")
        },
        {
          Name:"Dessert",
            Image: require("../assets/vapiano-dolci1.jpg")
        },
        {
          Name:"Drink",
            Image: require("../assets/drinks.jpg")
        }
      ],
      menu: { starters: [
          {
            Name : "Piatto Antipasti", price : 2250, image: require("../assets/vapiano-mozzarella.jpg")
          },
          {
            Name : "Cozze – friss fekete kagyló – fokhagymás fehérbormártásban", price : 2950,image: require("../assets/vapiano-salad.jpg")
          },
          {
            Name:"Toszkán paradicsomleves, ahogy mi gondoljuk (toszkán pecorino sajtkrémmel", price: 1990,image: require("../assets/vapiano-bruscetta.jpg")
          },
          {
            Name : "Négysajtos felfújt vargányagombával, fűszeres körtével és póréhagymaszalmával", price : 2250,image: require("../assets/soup.jpg")
          },

        ],
     mainDish: [
          {
            Name : "Toma sajttal töltött csirkemellfilé pancetta szalonnával göngyölve, erdeigomba-mártással", price : 3890, image: require("../assets/vapiano-pasta1.jpg")
          },
          {
            Name : "Sertésszűzérmék póréhagymakrémre tálalva, libamájéremmel, Primitivo bormártással", price : 4150, image: require("../assets/vapiano-pasta2.jpg")
          },
          {
            Name:"Porhanyós borjúpofa Barbera vörösbormártásban, polentakrémmel", price: 5890, image: require("../assets/vapiano-pasta3.jpg")
          },
          {
            Name : "Toma sajttal töltött csirkemellfilé pancetta szalonnával göngyölve, erdeigomba-mártással", price : 3890, image: require("../assets/vapiano-pizza1.jpg")
          },
          {
            Name : "Sertésszűzérmék póréhagymakrémre tálalva, libamájéremmel, Primitivo bormártással", price : 4150, image: require("../assets/vapiano-pasta2.jpg")
          },
          {
            Name:"Porhanyós borjúpofa Barbera vörösbormártásban, polentakrémmel", price: 5890, image: require("../assets/vapiano-pasta3.jpg")
          }
        ],
     desserts: [
          {
            Name : "Kézműves fagylaltok és szörbetek kívánság szerint", price : 450, image: require("../assets/vapiano-dolci1.jpg")
          },
          {
            Name : "Gratinírozott zabaionekrém friss trópusi és erdei gyümölcsökkel, maracujaszörbettel", price : 1990, image: require("../assets/vapiano-dolci2.jpg")
          },
          {
            Name:"Szivárványos panna cotta (gőzölt tejszínkrém) gyümölcspürével", price: 1150, image: require("../assets/vapiano-dolci3.jpg")
          },

        ]
      },
    }
  },
  methods: {
    switchEventCategory: function (id) {
      //imitate rest call:
      store.commit('clearCart');
      },
    addProduct: function (item) {
      store.commit('addToCart',item);
    }




  },
  computed: {
    ProductChunk: function(){
      return this.lodash.chunk(this.productCategories,3)
    },
  }
}
</script>

<style scoped>
.cards{
  background:  center no-repeat  url(../assets/vapiano.jpg);
  background-size: 100%;
  height: 598px;
}
  .container {
    background-color: white;
  }
  .home {
    margin-top: -60px;
  }

  .darkBacground {
    height: 598px;
    margin-top: -598px;
    background-color: rgba(0,0,0,0.3);
  }

  .descrition {
    background-color: white;
    height: 170px;
    margin-top: -150px;
    margin-bottom: 20px;
    border: solid 1px grey;
    border-radius: 0.3em;
  }
  .heart {
    cursor: pointer;
  }
  .heart:hover {
    background-color:black;
    opacity: 0.3;
  }
</style>
