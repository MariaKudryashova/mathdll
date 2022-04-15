function yy_approx = show_lsm(n, xmod, koeffs)

xmod = xmod';

if n == 3
    yy = [xmod.^3 xmod.^2 xmod ones(length(xmod),1)];
end
if n == 4
    yy = [xmod.^4 xmod.^3 xmod.^2 xmod ones(length(xmod),1)];
end
if n == 5
    yy = [xmod.^5 xmod.^4 xmod.^3 xmod.^2 xmod ones(length(xmod),1)];
end
if n == 6
    yy = [xmod.^6 xmod.^5 xmod.^4 xmod.^3 xmod.^2 xmod ones(length(xmod),1)];
end
if n == 7
    yy = [xmod.^7 xmod.^6 xmod.^5 xmod.^4 xmod.^3 xmod.^2 xmod ones(length(xmod),1)];
end
if n == 8
    yy = [xmod.^8 xmod.^7 xmod.^6 xmod.^5 xmod.^4 xmod.^3 xmod.^2 xmod ones(length(xmod),1)];
end
if n == 9
    yy = [xmod.^9 xmod.^8 xmod.^7 xmod.^6 xmod.^5 xmod.^4 xmod.^3 xmod.^2 xmod ones(length(xmod),1)];
end

yy_approx = yy * koeffs;
