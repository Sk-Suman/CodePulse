
import { Component ,OnInit} from '@angular/core';
import { FormsModule } from '@angular/forms';
import { RouterLink } from '@angular/router';
import { CategoryService } from '../../service/category.service';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-categoryblog',
  standalone: true,
  imports: [RouterLink,FormsModule,CommonModule],
  templateUrl: './categoryblog.component.html',
  styleUrl: './categoryblog.component.css'
})
export class CategoryblogComponent implements OnInit {

  DataId:any={
    id:"",
    name:"",
    urlHandel:""
  }


  Data:any={
    id:"",
    name:"",
    urlHandel:""
  };
  flag:boolean=false
 

  constructor(private service1:CategoryService)
  {
    this.service1=service1;
  }
  alldata:any[]=[];
  ngOnInit(): void {
    this.GetData();


  }

  // GetData()
  // {
  //   this.httpclient.get("https://localhost:7035/api/Categories").subscribe((res:any)=>
  //   {
  //     this.alldata=res;

  //   });

  GetData()
  {
    this.service1.GetAll().subscribe((res:any)=>{
      this.alldata=res;
    })
  }

  GetDataById(Id:any)
  {
   this.service1.GetById(Id).subscribe((res:any)=>
   {
    this.DataId=res;
   }
   
   )
   this.flag=true
  }

  BackToList()
  {
    this.flag=false
  }

  // OnEdit(data:any)
  // {
  //   this.Data=data;
  //   this.flag1=true
  // }

  // UpdateData(Id:any,Data:any)
  // {
    
  //  this.service1.Update(Id,Data).subscribe((res:any)=>
  //  {
  //   this.Data=res;
  //  });
  //  alert("data update sucessiful");
  // this.GetData();

  // }


  OnDelete(Id:any)
  {
    var r=confirm("are you sure to delete this ?");
    if(r){
    this.service1.Delete(Id).subscribe((res:any)=>
    {
      this.DataId=res;
    })
    alert("data deleted sucessifully")
   
   this.GetData();
  }
  this.GetData();
  }

}

