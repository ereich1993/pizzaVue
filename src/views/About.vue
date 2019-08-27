<template>
  <div class="App">
  </div>

</template>

<script>
    import gmapsInit from '../utils/gmaps';

    export default {
        name: 'About',
        async mounted() {

            const locations = [
                {
                    position: {
                       lat: 47.496860,
                        lng: 19.05125125
                    },
                },
                {
                    position: {
                        lat: 48.174270,
                        lng: 16.329620,
                    },
                },
            ];

            try {
                const google = await gmapsInit();


                const geocoder = new google.maps.Geocoder();
                const map = new google.maps.Map(this.$el);

                geocoder.geocode({ address: '47.496860,19.05125125' }, (results, status) => {
                    if (status !== 'OK' || !results[0]) {
                        throw new Error(status);
                    }
                    map.setCenter(results[0].geometry.location);
                    map.fitBounds(results[0].geometry.viewport);
                });
                const markers = locations
                           .map(x => new google.maps.Marker({ ...x, map }));
            } catch (error) {
                console.error(error);
            }
        },
    };
</script>

<style>
    html,
    body {
        margin: 0;
        padding: 0;
    }

    .App {
        width: 100vw;
        height: 45vh;
    }
</style>
