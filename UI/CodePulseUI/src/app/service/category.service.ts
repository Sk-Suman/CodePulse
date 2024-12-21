import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {

  // Data:object=
  // {
  //   Name:"",
  //   UrlHandel:""
  // };

  constructor(private httpclient:HttpClient) 
  {
    this.httpclient=httpclient;
   }

   GetAll()
   {
    return this.httpclient.get("https://localhost:7035/api/Categories");
   }

   GetById(Id:any)
   {
    return this.httpclient.get("https://localhost:7035/api/Categories/"+Id);
   }

   Update(Id:any,Data:any)
   {
    return this.httpclient.put("https://localhost:7035/api/Categories/Update/"+Id,Data);
   }

   Delete(Id:any)
   {
    return this.httpclient.delete("https://localhost:7035/api/Categories/Delete/"+Id);
   }


}
