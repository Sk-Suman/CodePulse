import { Routes } from '@angular/router';
import path from 'path';
import { CategoryblogComponent } from './component/categoryblog/categoryblog.component';
import { AddcategoryComponent } from './component/addcategory/addcategory.component';
import { HomeComponent } from './component/home/home.component';
import { EditCategoryComponent } from './component/edit-category/edit-category.component';


export const routes: Routes = [{
    path:"categoryblog",
    component:CategoryblogComponent
},
{
    path:"Addcategory",
    component:AddcategoryComponent
},
{
    path:"Home",
    component:HomeComponent
},
{
    path:"Edit/:id",
    component:EditCategoryComponent
}
];
