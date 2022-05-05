import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { CategoryServiceService } from 'src/app/services/category-service.service';

@Component({
  selector: 'app-create',
  templateUrl: './create.component.html',
  styleUrls: ['./create.component.css']
})
export class CreateComponent implements OnInit {

  createForm= new FormGroup({
    Name:new FormControl(''),
    Description:new FormControl(''),
    Active:new FormControl('')
  })

  constructor(private cat:CategoryServiceService) {

   }

  ngOnInit(): void {
  }

  create(){
    this.cat.CreateCategory(this.createForm.value).subscribe(data => {
      
     this.createForm.reset();
    });
  }
}
