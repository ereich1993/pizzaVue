<template>
    <div class="outerContainer">
        <div class="row">
            <div class="col-sm">
                <div class="row" style="margin-top: 35px">
                <div class="col-sm-2" style="font-size: 40px;margin-top: -15px" ><p>+</p></div>
                <div class="col-sm"  style="text-align: left;">
                    <p>{{content.Name}}</p>
                    <p style="color: #0019ff">{{content.price}}</p>
                </div>
                </div>
            </div>
            <div class="col-sm-5">
                <div class="pictureDiv" >
                    <img :src="content.image" alt="">
                </div>
            </div>
        </div>
    </div>
</template>

<script>
    export default {
        name: "smallProductCard",
        props: {
            content: {default: ""}
        },
        methods: {
            addProduct: function (item) {
                alert("here")
                store.commit('addToCart', item);
            }
        }
    }
</script>

<style scoped>
    .outerContainer {
        width: 560px;
        height: 167px;
        border-bottom: solid grey 1px;
        border-top: solid grey 1px;
        transition: transform .2s; /* Animation */
        transition: 0.3s;


    }
    .outerContainer:hover {
        width: 560px;
        height: 167px;
        border-bottom: solid grey 1px;
        border-top: solid grey 1px;
        transform: scale(1.03); /* (150% zoom - Note: if the zoom is too large, it will go outside of the viewport) */
        cursor: pointer;
    }
    img {
        height: 85%;
        object-fit: cover;
        width: 90%;
        border-radius: 10%;
    }
    .pictureDiv {
        height: 150px;
        width: 200px;
        margin-top: 20px;
        margin-right: 70px;

    }

</style>