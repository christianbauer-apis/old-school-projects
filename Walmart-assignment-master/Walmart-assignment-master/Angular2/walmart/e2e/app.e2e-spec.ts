import {
    browser, element, by
} from 'protractor';

  describe('endtoend test', () => {

it("should be able to add a new todo", () => {
    browser.get("/");


    let newTodoInput = element(
          by.css("input[type=text]"));
          newTodoInput.clear();
    newTodoInput.sendKeys("ipod");

    let SubmitButton = element(by.css("button[type=submit]"));
    SubmitButton.click();



});

});
