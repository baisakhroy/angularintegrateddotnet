import { DeleteService } from './components/delete/delete.service';
import { DeleteComponent } from './components/delete/delete.component';
import { HttppostComponent } from './components/httppost/httppost.component';

import { PostformComponent } from './components/postform/postform.component';

import { ProductinfoComponent } from './components/productinfogetall/productinfo.component';

import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './components/app/app.component';
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';
import { FetchDataComponent } from './components/fetchdata/fetchdata.component';
import { CounterComponent } from './components/counter/counter.component';

@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
        CounterComponent,
        FetchDataComponent,
        HomeComponent,
        ProductinfoComponent,
        PostformComponent,
        HttppostComponent,
        DeleteComponent
        
    ],
    providers: [DeleteService],
    imports: [
        CommonModule,
        HttpModule,
        FormsModule,
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            { path: 'counter', component: CounterComponent },
            { path: 'fetch-data', component: FetchDataComponent },
            { path: 'productinfo', component: ProductinfoComponent },
            { path: 'postform', component: PostformComponent },
            { path: 'httppost', component: HttppostComponent },
            { path: 'delete', component: DeleteComponent },
            { path: '**', redirectTo: 'home' }
        ])
    ]
})
export class AppModuleShared {
}
