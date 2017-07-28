new Vue({

    el: "#app",
    data: {
        firstName: "",
        lastName: ""
    },
    methods: {
        sendToServer: function () {

            axios({
                    method: 'post',
                    url: '/home/index',
                    data: {
                        "firstName": this.firstName,
                        "lastName": this.lastName
                    }
                })
                .then(function (response) {
                    console.log(response);
                })
                .catch(function (error) {
                    console.log(error);
                });

        }
    }

});