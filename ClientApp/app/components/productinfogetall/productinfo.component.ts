import { Component,Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'productinfo',
    templateUrl: './productinfo.component.html'
    
    

    
})



export class ProductinfoComponent{
    public productinfos: Productinformation[];
    
        
    

        constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
            http.get(baseUrl + 'api/todo').subscribe(result => {
                this.productinfos = result.json() as Productinformation[];
            }, error => console.error(error));
        }
    

    

        
        
    }
    interface Productinformation {
        ID : number;
        GroupID : number;
        Name : string;
        Description : string;
        Rate : number;
    }
