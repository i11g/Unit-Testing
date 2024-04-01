import {createCalculator} from './AddSubstract.js';
import{expect} from 'chai'; 

describe('createCalculator', ()=> {
    
    it('should return positive numbers if add operations are performed', ()=> {
        //Arrange
        const calcu=createCalculator();
        //Act
        calcu.add(5);
        calcu.add(5);
        calcu.add(8)
        const result=calcu.get();
        //Assert
        expect(result).to.be.equal(18) 
    })
    it('should return 0 when no operations are performed', ()=> {
        //Arrange
        const calculator=createCalculator();
        //Act
        const result=calculator.get();

        //Assert 
        expect(result).to.equal(0)
    }) 
    it('Should return negative if sunbstract operations are given',()=>{
        //Arrange 
        const calculator=createCalculator();
        //Act
        calculator.subtract(3);
        calculator.subtract(5);
        calculator.subtract(8) 
        const result=calculator.get();
        //Assert
        expect(result).to.equal(-16)
    })
    it('Should return negative when add operations with numbers as string are given',()=>{
        //Arrange 
        const calculator=createCalculator();
        //Act
        calculator.subtract('3');
        calculator.subtract('5');
        calculator.subtract('8') 
        const result=calculator.get();
        //Assert
        expect(result).to.equal(-16)
    })
    it('Should return positive when add operations with numbers as string and numbers are given',()=>{
        //Arrange 
        const calculator=createCalculator();
        //Act
        calculator.add("3");
        calculator.add(5);
        calculator.add(8) 
        const result=calculator.get();
        //Assert
        expect(result).to.equal(16)
    })
})
