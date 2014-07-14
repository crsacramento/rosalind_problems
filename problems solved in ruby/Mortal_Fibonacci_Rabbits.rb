n = 83
m = 19

bunnies = [0] * m 
bunnies[0] = 1
future_bunnies = 0

(1...n).each do |i|
	aux_bunnies = [0] * m
	(0...m).each { |a| aux_bunnies[a] = bunnies[a-1] }
	#puts "a#{aux_bunnies}"
	bunnies = aux_bunnies
	bunnies[0] = future_bunnies
	future_bunnies = bunnies.drop(1).inject(:+)	
	puts "#{i}|#{future_bunnies}|#{bunnies}"
end

puts "n|n|#{bunnies}"
puts bunnies.inject(:+)





	#bunnies.map! { |a| a += 1 }
	
	#bunnies.each do |a| 
	#	bunnies << 0 if a >=2
	#end

	#bunnies.select! { |b| b < m }

	#arr_bunnies = []
	#bunnies.each do |a|
	#	arr_bunnies << a if a < m
	#end
	#bunnies = arr_bunnies

#puts "#{i}:#{bunnies}"
#puts bunnies.count { |a| a > 0 }