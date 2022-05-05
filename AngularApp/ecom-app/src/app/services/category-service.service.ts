import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Category } from '../viewmodels/category';

@Injectable({
  providedIn: 'root'
})
export class CategoryServiceService {
  
  constructor(private http:HttpClient) { }

  GetCategoryList(){
    return this.http.get<Category[]>('https://localhost:44383/api/Category/GetAll');
  }
  CreateCategory(category:Category){
    return this.http.post<Category>('https://localhost:44383/api/Category/Create',category);
  }

}
