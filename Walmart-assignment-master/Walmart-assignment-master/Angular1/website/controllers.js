walmartApp.filter('escape', function(){
    return function (text) {
    return  String(text).replace("&amp;", " ").replace("&lt;/div&gt;", " ").replace("&gt;", " ").replace("&lt;div style=&quot;margin-left: 2em&quot;", 
    " ").replace("&lt;p", " ").replace("&lt;/p&gt;"," ").replace("&quot;", " ").replace("&lt;br&gt;", " ");
    };
});


//controllers
walmartApp.controller('homeController', ['$scope', '$location', 'productService', function($scope, $location, productService){
    $scope.product = productService.product;
    
    $scope.submit = function(){
     $location.path("/products");   
    };
    $scope.$watch('product', function(){
        productService.product = $scope.product;
    });
    
}]);


 var idValue = "";   
  

walmartApp.controller('productsController',['$scope', '$location', '$resource', 'searchService', 'lookupService', 'productService', function($scope, $location, $resource, searchService, lookupService, productService){
  
   
    $scope.product = productService.product; 
    $scope.search = searchService.search.get({query: $scope.product}).$promise.then(function(value){
         var ids = [];

        for(var i=0; i<10; i++){
     var id = value.items[i].itemId;
            ids.push(id);
            
        }
      console.log($scope.search);
     var things = ids.join();
        $scope.result = lookupService.lookup.get({ids: things});
    }).catch(function(data){
        
        alert("Please enter a valid search item.");
         $location.path("/"); 
    });
  
 $scope.add = function(itemId){
       idValue = itemId;
     
    };
    
}]);


walmartApp.controller('recommendController',['$scope', 'lookupService', 'recommendService', '$http', '$resource', function($scope, lookupService, recommendService, $http, $resource){
   
     $scope.yyy = lookupService.lookup.get({ids: idValue}); 
    //"http://api.walmartlabs.com/v1/nbp?apiKey=d9bgdny53rhfkkw6sg9xpjgu"
 //itemId: idValue
 
    
   //params:{itemId: idValue},
    
   
    var ids = [];
      $scope.why = recommendService.recommend.query({itemId: idValue}).$promise.then(setTimeout(function(data){
      
      
          console.log(data);
      for(var i=0; i<10; i++){
     
   //  var id = data[i].itemId;
       //     ids.push(id);
       }
   //    var things2 = ids.join();  
         // console.log(things2);
     // $scope.zzz = $scope.lookup2API.get({ids: things2}); 
   
    
      }),1000).then(function(data){
     // console.log(data);
      });
    
    
    
    
     }]);