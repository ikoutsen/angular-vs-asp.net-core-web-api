import { Component } from '@angular/core';
import { CalculatorService } from './calculator.service';
import { Point } from './point';

@Component({
    selector: 'app',
    templateUrl: './app.component.html',
    providers: [CalculatorService]
})

export class AppComponent {
    point1: Point = new Point(0, 0);
    point2: Point = new Point(0, 0);
    distance: number = 0;

    constructor(private calculator: CalculatorService) { }

    calculateDistance() {
        this.calculator.getDistance(this.point1, this.point2).subscribe(
            (result: number) => {
                this.distance = result;
            }
        );
    }
}