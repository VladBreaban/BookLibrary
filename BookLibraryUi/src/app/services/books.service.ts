import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { BookModel } from '../models/book';
import { environment } from 'src/environments/environment';


@Injectable({
  providedIn: 'root'
})
export class BooksService {

  constructor(private http: HttpClient) { }
  getBooks(){
    var response =  this.http.get<BookModel[]>(environment.urlServices + "Books/GetAllBooks");
    return response; 
  }

  addBook(model: BookModel){
    var response = this.http.post<BookModel>(environment.urlServices + "Books/CreateBook", model);
    console.log("after");
    return response;
  }
}
