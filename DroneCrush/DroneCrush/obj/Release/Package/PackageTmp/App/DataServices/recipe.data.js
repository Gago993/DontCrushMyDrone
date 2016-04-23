(function () {
    angular.module("app.data")
        .factory("RecipeData", RecipeData);

    RecipeData.$inject = ["$resource"];

    function RecipeData($resouce) {
        return $resouce("/api/recipes/:id", {}, {
            'recepiesForUserByUserId': {
                method: 'GET',
                url: "/api/recepiesByUser/:id",
                isArray: true
            }
        });
    }
})()