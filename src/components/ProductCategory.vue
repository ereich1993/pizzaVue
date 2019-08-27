<template>
    <section class="ProductCategory">
        <b-card style="margin-top: 10px"
                  no-body class=" active"  >
            <b-row no-gutters>
                <b-col md="12">
                    <b-card-img  style="height:198px" :src="category.Image" class="rounded-0"></b-card-img>
                </b-col>
            </b-row>

        </b-card>
    </section>
</template>


<script>
    export default {
        name: "ProductCategory",
        props: {
          category: {default : ""}
        },
    }
</script>

<style scoped>
    .active {
        box-shadow: 0 8px 16px 0 rgba(0,0,0,0.2);
        cursor: pointer;
    }


    .card.body {

    }
    .card {
        height: 200px;
        transition: 0.3s;
        border-color: grey;
        border-radius: 5px; /* 5px rounded corners */
        border-style: groove;
        margin-top: 10px;
        transition: transform .2s; /* Animation */
        margin: 0 auto;
        background-color: coral;
    }
    .card:hover {
        transform: scale(1.1); /* (150% zoom - Note: if the zoom is too large, it will go outside of the viewport) */
    }



</style>