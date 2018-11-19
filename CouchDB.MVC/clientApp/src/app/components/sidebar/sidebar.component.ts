import {MediaMatcher} from '@angular/cdk/layout';
import {ChangeDetectorRef, Component, OnDestroy, OnInit} from '@angular/core';
import { SidebarService } from './sidebar.service';
import { IPage } from '../../Interfaces/IPage';

/** @title Responsive sidenav */
@Component({
  selector: 'app-sidebar',
  templateUrl: 'sidebar.component.html',
  styleUrls: ['sidebar.component.css'],
})
export class SidebarComponent implements OnInit, OnDestroy {
  mobileQuery: MediaQueryList;
  pages: IPage[];
  private _mobileQueryListener: () => void;

  constructor(changeDetectorRef: ChangeDetectorRef, media: MediaMatcher, public sidebarService: SidebarService) {
    this.mobileQuery = media.matchMedia('(max-width: 600px)');
    this._mobileQueryListener = () => changeDetectorRef.detectChanges();
    this.mobileQuery.addListener(this._mobileQueryListener);
  }

  ngOnInit(): void {
    this.getPages();
  }

  getPages(): void {
    this.sidebarService.getAllPages().subscribe(
      (res: IPage[]) => {
        this.pages = res;
      }, (error: any) => {
        console.error(error);
      });
  }
  ngOnDestroy(): void {
    this.mobileQuery.removeListener(this._mobileQueryListener);
  }

  // tslint:disable-next-line:member-ordering
  shouldRun = [/(^|\.)plnkr\.co$/, /(^|\.)stackblitz\.io$/].some(h => h.test(window.location.host));
}
