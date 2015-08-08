var RecommendProductsController = function ($scope, $http) {
    $http.get("/DataSources/combingConditioners.json")
        .success(function (data) {
            var products = angular.fromJson(data.products);
            $scope.products = products;
        });
};

RecommendProductsController.$inject = ['$scope', '$http'];