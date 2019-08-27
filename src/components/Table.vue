<template>
    <div>
        <b-table v-b-modal.modal-1 v-if="result!==null" class="table" @row-clicked="addToCart($event.Name,$event.price,$event.image)" thead-class="hidden_header" hover   borderless :items="result.items"></b-table>
        <b-modal id="modal-1" title="BootstrapVue">
            <p class="my-4">{{this.currentSelection}}</p>
        </b-modal>
    </div>
</template>

<script>
    import store from "../store"
    export default {
        name: "Table",
        props:{
            result: Object
        },
        methods:{
            addToCart: function (result,proice,image) {
                var item = {
                    Name:result,price:proice,image:image
                };
                store.commit('addToCart',item);
                this.currentSelection = result
            }
        },
        data(){
            return {
                currentSelection:""
            }
        }
    }
</script>



<style>
    .hidden_header {
        display: none;
    }
    .table{
        text-align: left;
        cursor: pointer;
    }



</style>