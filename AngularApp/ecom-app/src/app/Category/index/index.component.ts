import { Component, OnInit } from '@angular/core';
import { CategoryServiceService } from 'src/app/services/category-service.service';
import { Category } from 'src/app/viewmodels/category';

@Component({
  selector: 'app-index',
  templateUrl: './index.component.html',
  styleUrls: ['./index.component.css']
})
export class IndexComponent implements OnInit {
  categories:Category[];
  constructor(private cat:CategoryServiceService) { }

  ngOnInit(): void {
    this.cat.GetCategoryList().subscribe(data => {
      this.categories = data;
    });
  }

}
