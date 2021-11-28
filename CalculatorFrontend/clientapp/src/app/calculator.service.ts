import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Point } from './point';

@Injectable()
export class CalculatorService {

    private url = "http://localhost:65006/api/calculator";
    private headers = new HttpHeaders()
        .append(
            'Content-Type',
            'application/json'
        );

    constructor(private http: HttpClient) {

    }

    getDistance(point1: Point, point2: Point) {
        return this.http.post(this.url, [point1, point2], {
            headers: this.headers
        });
    }
}