import {Injectable} from '@angular/core';
import { Jsonp, Response} from '@angular/http';
import {Observable} from 'rxjs/Rx';
@Injectable()
export class StoreService {

  constructor(private jsonp:Jsonp) { }

//https://stackoverflow.com/questions/37052617/how-to-deal-with-http-status-codes-other-than-200-in-angular-2?utm_medium=organic&utm_source=google_rich_qa&utm_campaign=google_rich_qa

Search(query:string){
  return  this.jsonp.get(`https://api.walmartlabs.com/v1/search?apiKey=d9bgdny53rhfkkw6sg9xpjgu&callback=JSONP_CALLBACK&query=${query}`).map(
    (response:Response)=>
  response.json()).catch((error:any)=>{

    if (error.status === 500)
     {
       return Observable.throw(error);
     }
     else if(error.status === 503){
        return Observable.throw(error);
     }
     else if(error.status === 504){
        return Observable.throw(error);
     }
   }
   );
}

Lookup(id:string){
  return  this.jsonp.get(`https://api.walmartlabs.com/v1/items?apiKey=d9bgdny53rhfkkw6sg9xpjgu&callback=JSONP_CALLBACK&ids=${id}`).map(
      (response:Response)=> response.json()).catch((error:any)=>{if (error.status === 500)
         {
           return Observable.throw(error);
         } else if(error.status === 503){
             return Observable.throw(error);
          }
          else if(error.status === 504){
             return Observable.throw(error);
          }
       }
       );
}

Recommend(id:string){
  return this.jsonp.get(`http://api.walmartlabs.com/v1/nbp?apiKey=d9bgdny53rhfkkw6sg9xpjgu&callback=JSONP_CALLBACK&itemId=${id}`).map(
      (response:Response)=> response.json()).catch((error:any)=>{if (error.status === 500)
         {
           return Observable.throw(error);
         }
       }
       );

}
}
