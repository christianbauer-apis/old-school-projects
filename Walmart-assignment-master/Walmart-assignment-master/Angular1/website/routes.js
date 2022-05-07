//routes
walmartApp.config(function ($routeProvider) {
    
   
    
    $routeProvider
    
    .when('/', {
        templateUrl: 'pages/home.html',
        controller: 'homeController'
    })
    
    .when('/products', {
        templateUrl: 'pages/products.html',
        controller: 'productsController'
    })
    
    .when('/recommend',{
        templateUrl: 'pages/recommend.html',
        controller: 'recommendController'
    })
});