import { JsonPipe } from '@angular/common';
import { HttpClient } from '@angular/common/http';
import { Component ,OnInit} from '@angular/core';
import { FormsModule } from '@angular/forms';
import { RouterLink,Router } from '@angular/router';
import { error } from 'console';
import { CategoryService } from '../../service/category.service';



@Component({
  selector: 'app-addcategory',
  standalone: true,
  imports: [RouterLink,FormsModule,JsonPipe],
  templateUrl: './addcategory.component.html',
  styleUrl: './addcategory.component.css'
})
export class AddcategoryComponent implements OnInit {


  Dataobj:any={
    Name:"",
    UrlHandel:""
  };
  data1:any[]=[];

  constructor(private httpclient:HttpClient,private service2:CategoryService,private router:Router)
  {
this.httpclient=httpclient;
this.service2=service2;
  }
  ngOnInit(): void {
    // this.service2.GetAll();
  }


  OnSubmit()
  {
    this.httpclient.post("https://localhost:7035/api/Categories",this.Dataobj).subscribe((res:any)=>
      {
      this.data1=res;
      alert("data added successfully");
      this.router.navigate(['/categoryblog'])
     
    
    
 
 
  },

);


}
}
