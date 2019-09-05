const homeUrl = "http://"+window.location.hostname+":55299/api/"

import axios from 'axios'



export async function restGet(controller){
    var getOptions = {
        method: 'GET',
        url: homeUrl + controller,
        headers: {
            //'auth': VueCookies.get('auth')
        },
        json: true
    };
    const response = await axios.get(getOptions);
    var resultParsed = JSON.parse(JSON.stringify(response.data));
    return resultParsed;
}

export async function restPost(controller,model) {
    console.log(controller,model)
    var postOptions = {
        method: 'POST',
        url: homeUrl + controller,
        data: JSON.stringify(model),
        headers: {
            'Content-Type':'application/json; charset=utf-8'
        },
        json:true
    };
    return axios(postOptions)
    .then(function(response){
        var responseParsed = JSON.parse(JSON.stringify(response.data))
        return responseParsed
    })
    .catch(function(error){
        console.log(error)
    })
}