import { Component,Inject } from '@angular/core';
import { Http } from '@angular/http';
import { Router,ActivatedRoute, ParamMap} from '@angular/router'
import {Response, Headers, RequestOptions} from '@angular/http';
  
@Component({
    selector:'Postform',
    templateUrl: './postform.component.html'
})




export class PostformComponent{

    constructor(public http: Http, @Inject('BASE_URL') public baseUrl: string){
        
    }



    post(id:number,groupID:number,name:string,description:string,rate:number) {
        
                 
        var headers = new Headers();
        headers.append('Content-Type', 'application/json; charset=utf-8');
        this.http.post(this.baseUrl+'api/Todo', JSON.stringify({id:id,groupID:groupID,name:name,description:description,rate:rate}), { headers: headers }).subscribe();
        //this.http.post(this.baseUrl+'api/Name', this.entry,{headers:headers}).subscribe();
               
    } 

    // let link = ['/httppost'];
    // this.router.navigate(link);

}
    

