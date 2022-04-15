%сгенерируем фактические значения
n = 9;
x = [1,2,3,4,5,6,7,8,9,10,11,12,13,14,15];
y = [3,5,4,6,7,7,4,5,6,7,8,9,6,6,7];
wts = ones(1, 15);

%аппроксимируем
koeffs = solve_lsm(n,x,y,wts);

%посмотрим что получилось
yy_approx = show_lsm(n, x, koeffs);

figure
p = plot(x,y,'r.',x,yy_approx,'-b');
grid on
legend('фактические значени¤','аппроксимаци¤','Location','northwest');

