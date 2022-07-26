import { Meta, moduleMetadata, Story } from '@storybook/angular';
import { EmployeeComponent } from "./employee.component";
import { HttpClientTestingModule } from '@angular/common/http/testing';
import { CommonModule } from '@angular/common';


export default {
  
  title: 'Header/Employee',
  component: EmployeeComponent,
  decorators: [
    moduleMetadata({
      imports: [CommonModule, HttpClientTestingModule],
    }),
  ],
} as Meta;

const Template: Story<EmployeeComponent> = (args: EmployeeComponent) => ({
 component: EmployeeComponent,
 props: args,
 template: '<app-employee [item]="item"></app-employee>'
});


const employeeData: Object[] = [];
employeeData.push({employeeNumber: '001', firstName: 'Jason', lastName: 'Gange'})
employeeData.push({employeeNumber: '002', firstName: 'Jason2', lastName: 'Gange2'})

export const EmployeeList = Template.bind({});

EmployeeList.args = {
  item:employeeData
}




