import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { MenuItem } from 'primeng/api';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent implements OnInit {
  constructor(private route: ActivatedRoute, private router: Router) {}

  items: MenuItem[] = [];
  title = 'Restaurant Management - Admin';

  ngOnInit(): void {
    this.items = [
      {
        label: 'Restaurant',
        icon: 'pi pi-fw pi-home',
        command: () => this.router.navigate(['/restaurant']),
      },
      {
        label: 'Role',
        icon: 'pi pi-fw pi-user-edit',
        command: () => this.router.navigate(['/role']),
      },
      {
        label: 'Status',
        icon: 'pi pi-fw pi-flag',
      },
      {
        label: 'Area',
        icon: 'pi pi-fw pi-share-alt',
      },
      {
        label: 'Unit',
        icon: 'pi pi-fw pi-filter',
        items: [
          {
            label: 'Unit Type',
          },
        ],
      },
    ];
  }
}
