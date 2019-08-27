<template>
    <div class="outerBorder">
        <div class="pictureDiv">
            <img :src="value.image">
        </div>
        <div class="middle">
            <div>
                <p class="upper">1x {{value.Name}}</p>
            </div>
            <div>
                <p style="margin-left: 20px" class="upper">{{value.price}}</p>
            </div>

        </div>
        <div class="lower">
            <b-row>
                <b-col md="6">
                    <p style="margin-left: 20px;margin-top: 25px">count: 1</p>
                </b-col>
                <b-col md="6">
                   <button style="margin-left: 20px">-</button><button>+</button>
                </b-col>
            </b-row>
        </div>
    </div>
</template>

<script>
    export default {
        name: "ProductCard",
        props : {
            value: {default : ""}
        }
    }
</script>

<style scoped>
    .outerBorder {
        height: 500px;
        width: 730px;
        border: lightslategray;
        border: solid;
        border-radius: 7px;
        border-width: 1px;
        margin-bottom: 15px;
    }

    .pictureDiv {
        height: 60%;
    }
    img {
        height: 100%;
        width: 100%;
    }
    .middle {
        height: 20%;
        text-align: left;
        border-bottom: solid;
        border-width: 1px;
    }
    .upper{
        margin-top: 15px;
        margin-left: 10px;
        font-size: 18px;
        font-family: Helvetica;


    }

    .lower{
        text-align: left;
    }
    button{
        margin-top: 5%;
        height: 90%;
        width: 30%;
        background: white;
        border-bottom-width: 1px;
        border-left-width: 1px;
        border-right-width: 1px;
        font-size: 30px;
        color:#0019ff; ;

    }
</style>