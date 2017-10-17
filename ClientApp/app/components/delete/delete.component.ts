import { ProductinfoComponent } from './../productinfogetall/productinfo.component';
import { DeleteService } from './delete.service';
import { Component,Inject,OnInit } from '@angular/core';
import { Http } from '@angular/http';
import {Response, Headers, RequestOptions} from '@angular/http';
import { ActivatedRoute,ParamMap,Router } from '@angular/router';
import 'rxjs/add/operator/switchMap';
import { Location }                 from '@angular/common';

@Component({
    selector:'delete',
    templateUrl: './delete.component.html'
})



export class DeleteComponent {

    constructor(public http:Http,private _delete: DeleteService, @Inject('BASE_URL') public baseUrl: string, private route: ActivatedRoute,private router: Router) { 
    }
    navigate:any;
    id:number;
    private sub: any;
}
    // ngOnInit() {
        // this.sub = this.route.params.subscribe(params => {
        //    this.id = +params['id']; // (+) converts string 'id' to a number
    
           
//   this.route.paramMap
//   .switchMap((params: ParamMap) => this._delete.Delete(+params.get('id')))
//   .subscribe(hero => this.hero = hero);
//            // In a real app: dispatch action to load the details here.
//         };
//       }

    

    
// constructor(private _service :DeleteService){}

//     private delete():void{
//         // console.log(id); //show`s id
//         this._service.deleteData()
//         .subscribe((data) => {console.log(data)});

// }


