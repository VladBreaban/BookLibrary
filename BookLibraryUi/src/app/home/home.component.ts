import { Component, OnInit } from '@angular/core';
import { BookModel } from '../models/book';
import { BooksService } from '../services/books.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  books: BookModel[] = [];
  bookModel: BookModel = new BookModel();
  constructor(private booksService: BooksService) { }

  ngOnInit(): void {
    this.populateDataSource();
  }
  populateDataSource() : void{
    this.books = [];
    this.booksService.getBooks().subscribe(x=>{
      this.books = x;
    });
  };

  addBook(){
    console.log(this.bookModel);
    this.booksService.addBook(this.bookModel).subscribe(x=>{
      this.populateDataSource();
      this.bookModel = new BookModel();
    })
  }
}
