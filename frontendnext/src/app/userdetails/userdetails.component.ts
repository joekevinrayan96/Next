import { Component, OnInit } from '@angular/core';
import { UserdetailsService } from '../shared/userdetails.service';

@Component({
  selector: 'app-userdetails',
  templateUrl: './userdetails.component.html',
  styles: [
  ]
})
export class UserdetailsComponent implements OnInit {

  constructor(public service:UserdetailsService) { }

  ngOnInit(): void {
    this.service.refreshList();
  }

}
