import { Component, OnInit } from '@angular/core';
import { Restaurant } from '../restaurant';
import { RestaurantService } from '../restaurant.service';

@Component({
  selector: 'app-restaurant-show',
  templateUrl: './restaurant-show.component.html',
  styleUrls: ['./restaurant-show.component.css']
})
export class RestaurantShowComponent implements OnInit {

  restaurants : Restaurant[];
  constructor(private _restaurantService :RestaurantService) {
    this._restaurantService.showRestaurant().subscribe({
      next: rs =>{
        this.restaurants = rs;
      }
    })
   }

  ngOnInit(): void {
  }

}
