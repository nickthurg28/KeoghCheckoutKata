# KeoghCheckoutKata

Implement a solution for a checkout kata that follows the requirements below.
1. Given I have selected to add an item to the basket Then the item should be added to the basket
2. Given items have been added to the basket Then the total cost of the basket should be calculated
3. Given I have added a multiple of 3 lots of item ‘B’ to the basket Then a promotion of ‘3 for 40’
should be applied to every multiple of 3 (see: Grid 1).
4. Given I have added a multiple of 2 lots of item ‘D’ to the basket Then a promotion of ‘25% off’
should be applied to every multiple of 2 (see: Grid 1).
Grid 1:
Item SKU Unit Price Promotions
A 10
B 15 3 for 40
C 40
D 55 25% off for every 2
purchased together

Items are priced individually. In addition, there are promotions which can affect the total price of the
basket, for example, when 3 lots of item ‘D’ are added to the basket then a 25% deduction is applied to
the total cost of 2 of those items. The pricing changes frequently, so pricing should be independent of the
checkout.

#Test Conventions
I always try and conform to this for naming conventions of tests - https://osherove.com/blog/2005/4/3/naming-standards-for-unit-tests.html
The tests have been written in an arrange act assert and red green refactor, then have been refactored e.g. to make objects into their own classes (models).
They have also been refactored to have test fixtures which makes the tests more readable.

#Next Steps
The next steps I would take for the this would be for an additional project called Checkout with the models pushed into there, along with the basket too.
