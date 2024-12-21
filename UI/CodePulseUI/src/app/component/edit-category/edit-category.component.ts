import { Component,OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { ActivatedRoute, RouterLink,Router } from '@angular/router';
import { CategoryService } from '../../service/category.service';

@Component({
  selector: 'app-edit-category',
  standalone: true,
  imports: [RouterLink,FormsModule],
  templateUrl: './edit-category.component.html',
  styleUrl: './edit-category.component.css'
})
export class EditCategoryComponent  implements OnInit{

catid:any

  constructor(private route:ActivatedRoute,private ser:CategoryService,private r:Router)
  {
this.route=route,
this.ser=ser
  }


ngOnInit(): void {
   this.catid= this.route.snapshot.paramMap.get('id')!;
  this.GetData();
}

Data:any={
  name:"",
  urlHandel:""
}

GetData()
{
 this.ser.GetById(this.catid).subscribe((res:any)=>
{
  this.Data=res;
})
}



OnSave()
{
   this.ser.Update(this.catid,this.Data).subscribe((res:any)=>{
    this.Data=res;
   })
   alert("update save sucessifully");
this.r.navigate(['/categoryblog'])
}
}
