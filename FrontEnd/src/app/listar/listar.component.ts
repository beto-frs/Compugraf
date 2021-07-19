import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ViewEncapsulation } from "@angular/core";

@Component({
  selector: 'app-listar',
  templateUrl: './listar.component.html',
  styleUrls: ['./listar.component.css'],
  encapsulation: ViewEncapsulation.None
})
export class ListarComponent implements OnInit {

  constructor(private http: HttpClient) { }

  private REST_API_SERVER = "http://localhost:8080/api";

  public usuarios = [] as any;

  ngOnInit(): void {
    this.http.get(this.REST_API_SERVER).subscribe((data: any)=>{
      this.usuarios = data;
    });
  }

}
