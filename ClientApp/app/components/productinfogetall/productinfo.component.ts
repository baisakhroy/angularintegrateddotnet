import { Component,Inject } from '@angular/core';
import { Http } from '@angular/http';
import { Router,ActivatedRoute, ParamMap} from '@angular/router'

@Component({
    selector: 'productinfo',
    templateUrl: './productinfo.component.html'
    
    

    
})



export class ProductinfoComponent{
    public productinfos: Productinformation[];
    
        private idtobepassed : number;
    

        constructor(public  http: Http, @Inject('BASE_URL') public baseUrl: string,private router:Router) {
            http.get(baseUrl + 'api/todo').subscribe(result => {
                this.productinfos = result.json() as Productinformation[];
            }, error => console.error(error));
        }
    
        delete(id:number){
            this.http.delete(this.baseUrl+'api/Todo/'+id).subscribe();
            
        }
        // delete(id:number):void{
        //         let link=['/delete',id];
        //         this.router.navigate(link);
               
        //     }
        }

    

        
        
    
    interface Productinformation {
        ID : number;
        GroupID : number;
        Name : string;
        Description : string;
        Rate : number;
    }
